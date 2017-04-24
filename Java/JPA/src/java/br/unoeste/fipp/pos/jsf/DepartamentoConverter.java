package br.unoeste.fipp.pos.jsf;

import br.unoeste.fipp.pos.entidades.Departamento;
import br.unoeste.fipp.pos.persistence.JPAManager;
import javax.faces.component.UIComponent;
import javax.faces.context.FacesContext;
import javax.faces.convert.Converter;
import javax.faces.convert.FacesConverter;
import javax.persistence.EntityManager;

/**
 *
 * @author Aluno
 */
@FacesConverter("DepartamentoConverter")
public class DepartamentoConverter implements Converter {
    @Override
    public Object getAsObject(FacesContext fc, UIComponent uic, String string) {
        int codigo = Integer.parseInt(string);
        EntityManager em = new JPAManager().getEntityManagerFactory().createEntityManager();
        try {
            return em.createNamedQuery("Departamento.findByDepCodigo", Departamento.class)
                    .setParameter("codigo", codigo).getSingleResult();
        } catch (Exception ex) {
            return null;
        } finally {
            em.close();
        }
    }
    @Override
    public String getAsString(FacesContext fc, UIComponent uic, Object o) {
        if (o != null) {
            return ((Departamento) o).getCodigo().toString();
        } else {
            return null;
        }
    }
}
